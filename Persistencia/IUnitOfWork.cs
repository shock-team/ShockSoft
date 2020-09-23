using System;

namespace ShockSoft.Persistencia
{
    public interface IUnitOfWork : IDisposable
    {
        void GuardarCambios();
    }
}
