﻿namespace Task1
{
    internal class Context
    {
        private IStrategy strategy;

        public Context(IStrategy strategy) 
        { 
        this.strategy = strategy;
        }
        public int ExecuteSrategy(int num1, int num2)
        {
            return strategy.DoOperation(num1, num2);
        }
    }

    public class context : operationMultipy
    {
        public int executeStrategy
        {
            get => default;
            set
            {
            }
        }

        public void Strategy()
        {
            throw new System.NotImplementedException();
        }
    }
}