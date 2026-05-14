using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text;
using APILearning.DTOs;

namespace Calculator.Service
{
    public class CalculatorService
    {
        private readonly HttpClient _httpClient;

        public CalculatorService()
        {
            _httpClient = new HttpClient();

            _httpClient.BaseAddress = new Uri("http://localhost:5103/");
        }

        public async Task<double> AddAsync(double number1, double number2)
        {
            var dto = new CalculationDto
            {
                Number1 = number1,
                Number2 = number2
            };

            var response = await _httpClient.PostAsJsonAsync(
                "api/calculator/add",
                dto
            );

            response.EnsureSuccessStatusCode();

            double result = await response.Content.ReadFromJsonAsync<double>();

            return result;
        }

        public async Task<double> SubtractAsync(double number1, double number2)
        {
            var dto = new CalculationDto
            {
                Number1 = number1,
                Number2 = number2
            };
            var response = await _httpClient.PostAsJsonAsync(
                "api/calculator/subtract",
                dto
            );
            response.EnsureSuccessStatusCode();
            double result = await response.Content.ReadFromJsonAsync<double>();
            return result;
        }

        public async Task<double> MultiplyAsync(double number1, double number2)
        {
            var dto = new CalculationDto
            {
                Number1 = number1,
                Number2 = number2
            };
            var response = await _httpClient.PostAsJsonAsync(
                "api/calculator/multiply",
                dto
            );
            response.EnsureSuccessStatusCode();
            double result = await response.Content.ReadFromJsonAsync<double>();
            return result;
        }

        public async Task<double> DivideAsync(double number1, double number2)
        {
            var dto = new CalculationDto
            {
                Number1 = number1,
                Number2 = number2
            };

            var response = await _httpClient.PostAsJsonAsync(
                "api/calculator/divide",
                dto
            );

            if (!response.IsSuccessStatusCode)
            {
                string errorMessage = await response.Content.ReadAsStringAsync();

                throw new Exception(errorMessage);
            }

            double result = await response.Content.ReadFromJsonAsync<double>();

            return result;
        }
    }
}
