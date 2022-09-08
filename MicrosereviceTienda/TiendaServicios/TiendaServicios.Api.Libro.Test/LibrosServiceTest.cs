using AutoMapper;
using GenFu;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using TiendaServicios.Api.Libro.Aplicacion;
using TiendaServicios.Api.Libro.Modelo;
using TiendaServicios.Api.Libro.Persistencia;
using Xunit;

namespace TiendaServicios.Api.Libro.Test
{
    public class LibrosServiceTest
    {
        private IEnumerable<LibreriaMaterial> ObtenerDataPrueba() {

            A.Configure<LibreriaMaterial>()
                .Fill(x => x.Titulo).AsArticleTitle()
                .Fill(x => x.LibreriaMaterialId, () => { return new Guid(); });

            var lista = A.ListOf<LibreriaMaterial>(30);
            lista[0].LibreriaMaterialId = Guid.Empty;

            return lista;
        }



        [Fact]
        public void GetLibros() {
            var mockContexto = new Mock<ContextoLibreria>();
            var mockMapper = new Mock<IMapper>();

            Consulta.Manejador manejador = new Consulta.Manejador(mockContexto.Object,mockMapper.Object);
        }
    }
}
