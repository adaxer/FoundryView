using System;
using System.Threading.Tasks;
using FoundryView.UseCases.Contracts.Interfaces;

namespace FoundryView.Data.DataSimulator
{
    public class DataSimulator : IDataConnector
    {
        private IObserver<(string key, string value)> _observer;

        public Task<bool> Connect(string address)
        {
            return Task.FromResult(true);
        }

        public Task<bool> Receive(IObserver<(string key, string value)> handler)
        {
            _observer = handler;
            return Task.FromResult(true);
        }

        public Task<bool> Send(string key, string data)
        {
            Console.WriteLine($"Key: {key}, Data: {data}");
            _observer?.OnNext((key, data));
            return Task.FromResult(true);
        }
    }
}
