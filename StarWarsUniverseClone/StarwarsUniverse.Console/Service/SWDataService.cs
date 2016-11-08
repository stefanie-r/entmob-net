﻿using Newtonsoft.Json;
using StarwarsUniverse.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsUniverse.Clone.Service
{
    class SWDataService : ISWDataService {
        public List<SWMovie> GetAllSWMovies() {
            string swapifilms = "http://swapi.co/api/films";
            var uri = new Uri(String.Format("{0}?format=json", swapifilms));
            var client = new HttpClient();
            var response = Task.Run(() => client.GetAsync(uri)).Result;
            response.EnsureSuccessStatusCode();
            var result = Task.Run(() => response.Content.ReadAsStringAsync()).Result;
            var root = JsonConvert.DeserializeObject<RootObject<SWMovie>>(result);
            return root.results;
        }
        public List<SWPlanet> GetAllSWPlanets()
        {
            string swapifilms = "http://swapi.co/api/planets";
            var uri = new Uri(String.Format("{0}?format=json", swapifilms));
            var client = new HttpClient();
            var response = Task.Run(() => client.GetAsync(uri)).Result;
            response.EnsureSuccessStatusCode();
            var result = Task.Run(() => response.Content.ReadAsStringAsync()).Result;
            var root = JsonConvert.DeserializeObject<RootObject<SWPlanet>>(result);
            return root.results;
        }
        public SWMovie GetSWMovieDetails(string uri) {
            var client = new HttpClient();
            var response = Task.Run(() => client.GetAsync(uri)).Result;
            response.EnsureSuccessStatusCode();
            var result = Task.Run(() => response.Content.ReadAsStringAsync()).Result;
            var movie = JsonConvert.DeserializeObject<SWMovie>(result);
            return movie;
        }
    }
    class RootObject<T> {
        public int count { get; set; }
        public object next { get; set; }
        public object previous { get; set; }
        public List<T> results { get; set; }
    }
}