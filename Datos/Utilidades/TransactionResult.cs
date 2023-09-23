using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Utilidades
{
    internal class TransactionResult
    {
        public bool IsOk { get; set; }
        public int Id { get; set; }
        public string Error { get; set; }
    }
}
