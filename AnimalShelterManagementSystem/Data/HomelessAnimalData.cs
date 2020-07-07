﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AnimalShelterManagementSystem
{
    public class HomelessAnimalData : EntityData<HomelessAnimal>
    {

        public HomelessAnimal Get(int homelessAnimalId)
        {
            AnimalShelterManagementEntities context = CreateContext();

            return context.HomelessAnimals.FirstOrDefault(a => a.HomelessAnimalId == homelessAnimalId);
        }

        public void Delete(int homelessAnimalId)
        {
            HomelessAnimal homelessAnimal = Get(homelessAnimalId);

            if (homelessAnimal == null)
                return;

            Delete(homelessAnimal);
        }

        public int GetMaxId()
        {
            AnimalShelterManagementEntities context = CreateContext();

            var query = from x in context.HomelessAnimals
                        orderby x.HomelessAnimalId descending
                        select x.HomelessAnimalId;

            return query.FirstOrDefault();

        }

        public int GetFirstId()
        {
            AnimalShelterManagementEntities context = CreateContext();

            var query = from x in context.HomelessAnimals
                        orderby x.HomelessAnimalId 
                        select x.HomelessAnimalId;

            return query.FirstOrDefault();
        }

        public void IsAdopted(int homelessAnimalId)
        {
            AnimalShelterManagementEntities context = CreateContext();

           context.HomelessAnimals.FirstOrDefault(a => a.HomelessAnimalId == homelessAnimalId);
        }

        public List<HomelessAnimal> SearchWithAnimals(int speciesCode, bool isMale, bool isFemale)
        {
            AnimalShelterManagementEntities context = CreateContext();


            var query = from x in context.HomelessAnimals
                        where x.SpeciesCode == speciesCode && x.IsAdopted == false
                        select new { 
                            Animal = x, 
                            PhysicalConditionName = x.PhysicalCondition.Name,
                            SpeciesName = x.Species.Name
                        };

            if (isMale)
                query = query.Where(x => x.Animal.SexId == 1);

            if (isFemale)
                query = query.Where(x => x.Animal.SexId == 2);

            var list = query.ToList();

            foreach (var x in list)
            {
                x.Animal.SpeciesName = x.SpeciesName;
                x.Animal.PhysicalConditionName = x.PhysicalConditionName;
            }

            return list.ConvertAll(x => x.Animal);

        }

    //    public List<HomelessAnimal> SearchWithAnimals(int speciesCode)
    //{
    //    AnimalShelterManagementEntities context = CreateContext();
    //    var query = from x in context.HomelessAnimals
    //                where x.SpeciesCode == speciesCode && x.IsAdopted == false
    //                select x;
    //    return query.ToList();
    //}
}
}
