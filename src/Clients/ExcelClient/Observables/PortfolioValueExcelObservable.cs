﻿//  Copyright (c) RXD Solutions. All rights reserved.
using System;
using ExcelDna.Integration;
using RxdSolutions.FusionLink.Client;
using RxdSolutions.FusionLink.ExcelClient.Properties;

namespace RxdSolutions.FusionLink.ExcelClient
{
    public class PortfolioValueExcelObservable : IExcelObservable
    {
        private readonly DataServiceClient _rtdClient;
        private IExcelObserver _observer;

        public PortfolioValueExcelObservable(int portfolioId, string column, DataServiceClient rtdClient)
        {
            PortfolioId = portfolioId;
            Column = column;
            _rtdClient = rtdClient;
        }

        public int PortfolioId { get; }

        public string Column { get; }

        public IDisposable Subscribe(IExcelObserver observer)
        {
            _observer = observer;
            _rtdClient.OnPortfolioValueReceived += OnPortfolioValueSent;

            try
            {
                if (_rtdClient.State == System.ServiceModel.CommunicationState.Opened)
                    _observer.OnNext(Resources.SubscribingToData);
                else
                    _observer.OnNext(Resources.NotConnectedMessage);

                _rtdClient.SubscribeToPortfolioValue(PortfolioId, Column);
            }
            catch(Exception ex)
            {
                _observer.OnNext(ex.Message);
            }

            return new ActionDisposable(CleanUp);
        }

        private void OnPortfolioValueSent(object sender, PortfolioValueReceivedEventArgs args)
        {
            if (args.PortfolioId == PortfolioId && args.Column == Column)
            {
                if (args.Value is null)
                    _observer.OnNext(ExcelEmpty.Value);
                else
                    _observer.OnNext(args.Value);
            }
        }

        void CleanUp()
        {
            _rtdClient.OnPortfolioValueReceived -= OnPortfolioValueSent;

            try
            {
                _rtdClient.UnsubscribeToPortfolioValue(PortfolioId, Column);
            }
            catch(Exception)
            {
                //Sink... not much we can do.
            }
        }
    }
}