using System;
using System.Collections.Generic;
using CollectionViewTest.Models;
using MvvmHelpers;

namespace CollectionViewTest.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        public ObservableRangeCollection<Animal> Animals { get; }

        public ItemsViewModel()
        {
            var mockData = new List<Animal>()
            {
                { new Animal() { Name = "Ariel", Age = 63, Species = "Tortoise" } },
                { new Animal() { Name = "Hershey", Age = 3, Species = "Cat" } },
                { new Animal() { Name = "Champ", Age = 7, Species = "Horse" } },
                { new Animal() { Name = "Lars", Age = 10, Species = "Monkey" } },
                { new Animal() { Name = "Gladys", Age = 1, Species = "Goldfish" } },
                { new Animal() { Name = "Shelby", Age = 4, Species = "Dog" } },
                { new Animal() { Name = "Tonka", Age = 5, Species = "Snake" } }
            };

            Animals = new ObservableRangeCollection<Animal>(mockData);
        }
    }
}
