using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Caching;
using Core.Utililies.Interceptors;
using Core.Utililies.IoC;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Aspects.Autofac.Caching  //cache de bir sıkıntı çıkması durumunda burası kullanılır güncelleme ekleme gibi hatalar
{
    public class CacheRemoveAspect : MethodInterception
    {
        private string _pattern;
        private ICacheManager _cacheManager;

        public CacheRemoveAspect(string pattern)
        {
            _pattern = pattern;
            _cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();
        }

        protected override void OnSuccess(IInvocation invocation)
        {
            _cacheManager.RemoveByPattern(_pattern); //pattern e göre silme işlemi yapıyır
        }
    }
}
