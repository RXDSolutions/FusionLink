﻿//  Copyright (c) RXD Solutions. All rights reserved.
using System;
using ExcelDna.Integration;
using RxdSolutions.FusionLink.Client;
using RxdSolutions.FusionLink.ExcelClient.Properties;

namespace RxdSolutions.FusionLink.ExcelClient
{
    public class ConnectionNameExcelObservable : IExcelObservable
    {
        private readonly DataServiceClient _rtdClient;
        private readonly ServerConnectionMonitor _availableConnections;
        private IExcelObserver _observer;

        public ConnectionNameExcelObservable(DataServiceClient rtdClient, ServerConnectionMonitor availableConnections)
        {
            _rtdClient = rtdClient;
            _availableConnections = availableConnections;
        }

        public IDisposable Subscribe(IExcelObserver observer)
        {
            _observer = observer;

            _rtdClient.OnConnectionStatusChanged += OnConnectionStatusChanged;
            _availableConnections.AvailableEndpointsChanged += AvailableEndpointsChanged;

            if (_rtdClient.Connection is object)
            {
                _observer.OnNext(new ConnectionBuilder(_rtdClient.Connection.Uri).GetConnectionName());
            }
            else
            {
                _observer.OnNext(Resources.NotConnectedMessage);
            }

            return new ActionDisposable(CleanUp);
        }

        private void AvailableEndpointsChanged(object sender, EventArgs e)
        {
            UpdateConnectionName();
        }

        private void OnConnectionStatusChanged(object sender, ConnectionStatusChangedEventArgs e)
        {
            UpdateConnectionName();
        }

        private void UpdateConnectionName()
        {
            if (_rtdClient.Connection is object)
            {
                _observer.OnNext(new ConnectionBuilder(_rtdClient.Connection.Uri).GetConnectionName());
            }
            else
            {
                _observer.OnNext(Resources.NotConnectedMessage);
            }
        }

        private void CleanUp()
        {
            _rtdClient.OnConnectionStatusChanged -= OnConnectionStatusChanged;
        }
    }
}