using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;
using System.Net;
using TrainGR.Models;
using TrainGR.Repository;

namespace TrainGR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainController : ControllerBase
    {
        private IRepository<Train> _train;

        public TrainController()
        {
            _train = new Repository<Train>();
        }
        [HttpGet]     
        public IEnumerable<Train> GetTrain()
        {
            var result= _train.GetAll();
            return result;
        }
        [HttpGet("{id}")]
        public Train GetById(int id)
        {
            var result=_train.GetByID(id);
            return result;
        }
        [HttpPost]
        public Train Insert(Train train)
        {            
            var result = _train.ADD(train);
            return result;
        }
        [HttpPut("{id}")]
        public Train UpdateTrain(Train train)
        {          
         var result = _train.UPDATE(train);
            return result;

        }
        [HttpDelete("{id}")]
        public Train Delete(Train train)
        {
            var result = _train.Deletes(train);
            return result;
        }
    }
}
