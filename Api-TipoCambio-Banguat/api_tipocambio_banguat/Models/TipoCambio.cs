using System.ComponentModel.DataAnnotations;
namespace api_tipocambio_banguat.Models{
    public class ValoresDelWs{
        [Key]
        public int idvaloresdelws{get;set;}
        public string fecha{get;set;}
        public int moneda{get;set;}
        public float compra{get;set;}
        public float venta{get;set;}
}
}