using LogicDB.BindingModels;
using LogicDB.Models;
using LogicDB.Storages;
using LogicDB.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDB.Logics
{
    public class OrderLogic
    {
        private readonly OrderStorage _orderStorage;

        public OrderLogic()
        {
            _orderStorage = new OrderStorage();
        }

        public void CreateOrUpdate(WorkerBindingModel model)
        {
            var element = _orderStorage.GetElement(new WorkerBindingModel
            {
                Id = model.Id
            });

            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже есть поставщик с таким id");
            }

            if (model.Id.HasValue)
            {
                _orderStorage.Update(model);
            }
            else
            {
                _orderStorage.Insert(model);
            }
        }

        public void Create(WorkerBindingModel model)
        {
            _orderStorage.Insert(model);
        }

        public void Update(WorkerBindingModel model)
        {
            var element = _orderStorage.GetElement(model);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            _orderStorage.Update(model);
        }

        public void Delete(WorkerBindingModel model)
        {
            var element = _orderStorage.GetElement(new WorkerBindingModel
            {
                Id = model.Id
            });

            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }

            _orderStorage.Delete(model);
        }

        public List<WorkerViewModel> Read(WorkerBindingModel model)
        {
            if (model == null)
            {
                return _orderStorage.GetFullList();
            }

            if (model.Id.HasValue)
            {
                return new List<WorkerViewModel>()
                {
                    _orderStorage.GetElement(model)
                };
            }
            return _orderStorage.GetFilteredList(model);
        }


    }
}
