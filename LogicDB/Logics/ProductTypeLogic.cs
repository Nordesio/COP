using LogicDB.BindingModels;
using LogicDB.Storages;
using LogicDB.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDB.Logics
{
    public class ProductTypeLogic
    {
        private readonly ProductTypeStorage _storage;

        public ProductTypeLogic()
        {
            _storage = new ProductTypeStorage();
        }

        public void CreateOrUpdate(SkillTypeBindingModel model)
        {
            var element = _storage.GetElement(new SkillTypeBindingModel
            {
                Name = model.Name
            });

            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже есть тип товара с таким названием");
            }

            if (model.Id.HasValue)
            {
                _storage.Update(model);
            }
            else
            {
                _storage.Insert(model);
            }
        }

        public void Delete(SkillTypeBindingModel model)
        {
            var element = _storage.GetElement(new SkillTypeBindingModel
            {
                Id = model.Id
            });

            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }

            _storage.Delete(model);
        }

        public List<SkillTypeViewModel> Read(SkillTypeBindingModel model)
        {
            if (model == null)
            {
                return _storage.GetFullList();
            }

            if (model.Id.HasValue)
            {
                return new List<SkillTypeViewModel>
                {
                    _storage.GetElement(model)
                };
            }

            return _storage.GetFilteredList(model);
        }
    }
}
