using LogicDB.BindingModels;
using LogicDB.Models;
using LogicDB.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDB.Storages
{
    public class ProductTypeStorage
    {
        public void Delete(SkillTypeBindingModel model)
        {
            using var context = new WorkersDatabase();
            var element = context.SkillTypes
                .FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.SkillTypes.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }

        public SkillTypeViewModel GetElement(SkillTypeBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new WorkersDatabase();
            var element = context.SkillTypes
                .FirstOrDefault(rec => rec.Name == model.Name || rec.Id == model.Id);
            return element != null ? CreateModel(element) : null;
        }

        public List<SkillTypeViewModel> GetFilteredList(SkillTypeBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new WorkersDatabase();
            return context.SkillTypes
                .Where(rec => rec.Name == model.Name)
                .ToList()
                .Select(CreateModel)
                .ToList();
        }

        public List<SkillTypeViewModel> GetFullList()
        {
            using var context = new WorkersDatabase();
            return context.SkillTypes
                .ToList()
                .Select(CreateModel)
                .ToList();
        }

        public void Insert(SkillTypeBindingModel model)
        {
            using var context = new WorkersDatabase();
            using var transaction = context.Database.BeginTransaction();
            try
            {
                context.SkillTypes.Add(CreateModel(model, new SkillType()));
                context.SaveChanges();
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        public void Update(SkillTypeBindingModel model)
        {
            using var context = new WorkersDatabase();
            using var transaction = context.Database.BeginTransaction();
            try
            {
                var element = context.SkillTypes
                    .FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Элемент не найден");
                }
                CreateModel(model, element);
                context.SaveChanges();
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        private static SkillType CreateModel(SkillTypeBindingModel model, SkillType product)
        {
            product.Name = model.Name;
            return product;
        }

        private static SkillTypeViewModel CreateModel(SkillType product)
        {
            return new SkillTypeViewModel
            {
                Id = product.Id,
                Name = product.Name
            };
        }
    }
}
