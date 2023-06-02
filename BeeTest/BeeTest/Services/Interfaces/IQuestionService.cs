﻿using BeeTest.Models;

namespace BeeTest.Services.Interfaces
{
    public interface IQuestionService
    {
        Task<bool> AddOrUpdate(Question question);
        Task<List<Question>> GetQuestionsByTestId(int testId); 
    }
}