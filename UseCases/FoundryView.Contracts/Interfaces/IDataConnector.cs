using System;
using System.Threading.Tasks;

namespace FoundryView.UseCases.Contracts.Interfaces
{
    public interface IDataConnector
    {
        Task<bool> Connect(string address);
        Task<bool> Send(string key, string data);
        Task<bool> Receive(IObserver<(string key, string value)> handler);
    }

}
