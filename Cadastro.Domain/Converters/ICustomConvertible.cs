using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Domain.Converters
{
    public interface ICustomConvertible
    {
        Type? Type { get; }
    }
}
