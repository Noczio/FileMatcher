using System.Collections.Generic;

namespace AppGetSameFiles.resources.interfaces
{
    public interface IEnabler
    {
        void ValidateNode();

        bool ValidateCondition();
    }

    public interface IPool<T>
    {
        void Add(T _data);      
        List<T> Return();
    }

    public interface IEPool : IPool<IEnabler>
    {
        void ValidateNodes();
    }
}