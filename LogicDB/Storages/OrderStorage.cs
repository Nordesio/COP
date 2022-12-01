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
    public class OrderStorage
    {
        public void Delete(WorkerBindingModel model)
        {
            using var context = new WorkersDatabase();
            var element = context.Workers
                .FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.Workers.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }

        public WorkerViewModel GetElement(WorkerBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new WorkersDatabase();
            var order = context.Workers
                .FirstOrDefault(rec => rec.Id == model.Id);
            return order != null ? CreateModel(order) : null;
        }

        public List<WorkerViewModel> GetFilteredList(WorkerBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new WorkersDatabase();
            return context.Workers
                .Where(rec => rec.Id.Equals(model.Id))
                .ToList()
                .Select(CreateModel)
                .ToList();
        }

        public List<WorkerViewModel> GetFullList()
        {
            using var context = new WorkersDatabase();
            return context.Workers
                .ToList()
                .Select(CreateModel)
                .ToList();
        }

        public void Insert(WorkerBindingModel model)
        {
            using var context = new WorkersDatabase();
            using var transaction = context.Database.BeginTransaction();
            try
            {
                context.Workers.Add(CreateModel(model, new Worker()));
                context.SaveChanges();
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        public void Update(WorkerBindingModel model)
        {
            using var context = new WorkersDatabase();
            using var transaction = context.Database.BeginTransaction();
            try
            {
                var element = context.Workers
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

        private static Worker CreateModel(WorkerBindingModel model, Worker order)
        {
            order.WorkerName = model.WorkerName;
            order.Image = model.Image;
            order.SkillType = model.SkillType;
            order.PhoneNumber = model.PhoneNumber;
            return order;
        }

        private static WorkerViewModel CreateModel(Worker order)
        {
            return new WorkerViewModel
            {
                Id = order.Id,
                WorkerName = order.WorkerName,
                Image = order.Image,
                SkillType = order.SkillType,
                PhoneNumber = order.PhoneNumber
            };
        }

    }
}
