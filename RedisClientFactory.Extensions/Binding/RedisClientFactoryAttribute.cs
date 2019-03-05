using System;
using Microsoft.Azure.WebJobs.Description;

namespace RedisClientFactory.Extensions.Binding
{
    [Binding]
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
    public sealed class RedisClientFactoryAttribute : Attribute
    {
        
    }
}