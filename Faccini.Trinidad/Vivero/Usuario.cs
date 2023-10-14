using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    public class Usuario
    {
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Legajo { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public string Vendedor { get; set; }

    }
}

    /*
     * 
    [{"apellido":"Gorgen","nombre":"Corey","legajo":1,"correo":"cgorgen@vendedor.com","clave":"123abc45","perfil":"vendedor"},
{ "apellido":"Harroll","nombre":"Ingrid","legajo":2,"correo":"iharroll@vendedor.com","clave":"qweasdzx","perfil":"vendedor"},
{ "apellido":"Harris","nombre":"Steve","legajo":3,"correo":"sharris@maiden.com.uk","clave":"eddie666","perfil":"vendedor"},
{ "apellido":"Robinson","nombre":"Tilda","legajo":4,"correo":"trobinson@super.com","clave":"12345678","perfil":"supervisor"},
{ "apellido":"Jordan","nombre":"Michael","legajo":5,"correo":"admin@admin.com","clave":"12345678","perfil":"administrador"}]
    */