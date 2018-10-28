using System;
using System.Collections.Generic;
using System.Linq;
using AgileHub102018.Entities;
using AgileHub102018.Models.Puppets;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AgileHub102018.Controllers
{
    public class PuppetsController : Controller
    {
        private List<Dog> _dogs;
        private readonly AgileHubContext _agileHubContext;

        public PuppetsController(AgileHubContext agileHubContext)
        {
            _agileHubContext = agileHubContext;
        }

        public IActionResult Index()
        {
            _dogs = _agileHubContext
                .Dogs
                .Include(d => d.DogAddress)
                .Select(d => MapEntityToModel(d))
                .ToList();
         
            return View(_dogs);
        }

        private Dog MapEntityToModel(DogEntity d)
        {
            return new Dog()
            {
                Name = d.Name,
                BirthDay = d.BirthDay,
                Id = d.Id,
                DogAddress = new Address()
                {
                    City = d.DogAddress.City
                },
                CreditCard = d.CreditCard,
                Email = d.Email,
                Vaccines = new List<string>()
            };
        }

        public IActionResult GetByName(string name)
        {
            var dogs = _agileHubContext
                .Dogs
                .Include(d => d.DogAddress)
                .Where(d => d.Name.Contains(name))
                .ToList()
                .Select(d => MapEntityToModel(d));

            return View("Index", dogs);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var dog = _dogs.FirstOrDefault(d => d.Id == id);

            return View("_EditDog", dog);
        }

        [HttpPost]
        public IActionResult Edit(Dog dog)
        {
            if (!ModelState.IsValid)
            {
                return View("_EditDog", dog);
            }

            int index = _dogs.FindIndex(d => d.Id == dog.Id);
            _dogs[index] = dog;

            return View("Index", _dogs);
        }
    }
}