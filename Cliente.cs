using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clientes
{
    public class Cliente
    {
        private String Nombre;
        private String Apellidos;
        private String Ciudad;
        private String Email;
        private String Comentario;
        private String RutaFoto;
        private Boolean Vip;

        public Cliente(String nombre, String apellidos, String ciudad, String email, String comentario, Boolean vip)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Ciudad = ciudad;
            this.Email = email;
            this.Vip = vip;
            this.Comentario = comentario;
        }

        public Cliente(String nombre, String apellidos, String ciudad, String email, String comentario, Boolean vip, String rutaFoto)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Ciudad = ciudad;
            this.Email = email;
            this.Vip = vip;
            this.Comentario = comentario;
            this.RutaFoto = rutaFoto;
        }

        public String getNombre()
        {
            return this.Nombre;
        }

        public String getApellidos()
        {
            return this.Apellidos;
        }

        public String getCiudad()
        {
            return this.Ciudad;
        }

        public String getEmail()
        {
            return this.Email;
        }

        public String getComentario()
        {
            return this.Comentario;
        }

        public String getRutaFoto()
        {
            return this.RutaFoto;
        }

        public Boolean getVip()
        {
            return this.Vip;
        }
    }
}
