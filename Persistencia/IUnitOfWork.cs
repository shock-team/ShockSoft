using System;

namespace ZonaSoft.Persistencia
{
    public interface IUnitOfWork : IDisposable
    {
        void GuardarCambios();
    }
}
