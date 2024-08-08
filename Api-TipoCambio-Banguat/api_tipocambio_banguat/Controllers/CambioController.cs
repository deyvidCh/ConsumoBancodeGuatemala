using Microsoft.AspNetCore.Mvc;
using System.Linq;
using api_tipocambio_banguat.Models;
namespace api_tipocambio_banguat.Controllers{
    [Route("api/[controller]")]
    public class CambioController : Controller{
       private Conexion dbConexion;
       public CambioController(){
           dbConexion=conectar.Create();

       } 
       [HttpGet]
       public ActionResult Get(){
           return Ok(dbConexion.ValoresDelWs.ToArray());
       }
       [HttpGet("{id}")]
        public ActionResult Get(int id){
            var valoresdelws = dbConexion.ValoresDelWs.SingleOrDefault( a => a.idvaloresdelws ==id);
            if (valoresdelws != null){
                return Ok(valoresdelws);
            }else{
                return NotFound();
            }

        }
        /*[HttpPost]
        public ActionResult Post([FromBody] TiposdeCambio tiposdecambio){
            if(ModelState.IsValid){
                dbConexion.TiposdeCambio.Add(tiposdecambio);
                dbConexion.SaveChanges();
                return Ok(tiposdecambio);
            }else{
                return NotFound();
            }

        }
        [HttpPut]
        public ActionResult Put([FromBody] TiposdeCambio tiposdecambio){
            var v_tiposdecambio = dbConexion.TiposdeCambio.SingleOrDefault(a => a.idtipocambio ==tiposdecambio.idtipocambio);
            if(ModelState.IsValid && v_tiposdecambio !=null){
                dbConexion.Entry(v_tiposdecambio).CurrentValues.SetValues(tiposdecambio);
                dbConexion.SaveChanges();
                return Ok();
            }else{
                return NotFound();
            }

        }*/

        [HttpDelete("{id}")]
        public ActionResult Delete(int id){
             var valoresdelws = dbConexion.ValoresDelWs.SingleOrDefault( a => a.idvaloresdelws == id);
             if(valoresdelws !=null){
                dbConexion.ValoresDelWs.Remove(valoresdelws);
                dbConexion.SaveChanges();
                return Ok();

             }else{
                return NotFound();
             }
        }     
    }
}

