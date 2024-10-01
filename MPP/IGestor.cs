using System.Collections.Generic;

namespace MPP
{
    public interface IGestor<T>
    {
        bool Guardar(T Objeto);

        bool Baja(T Objeto);

        List<T> ListarTodo();

        T ListarObjeto(T Objeto);
    }
}
