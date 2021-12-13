using Castle.DynamicProxy;
using System;

namespace Core.Utilities.Interceptors
{
    public abstract class MethodInterception : MethodInterceptionBaseAttribute
    {
        //inovaction : business method -- yani iş methodları (add, delete, update..)
        protected virtual void OnBefore(IInvocation invocation) { }// virtual method senın ezmeni bekleyen method demektir. yani biz bir aspect yazdıgımız zamnan onun nerede çalışmasını ıstıyorsak gıdıp onun ilgili methodlarını ezıyoruz.
        protected virtual void OnAfter(IInvocation invocation) { }
        protected virtual void OnException(IInvocation invocation, System.Exception e) { }
        protected virtual void OnSuccess(IInvocation invocation) { }
        public override void Intercept(IInvocation invocation)
        {
            var isSuccess = true;
            OnBefore(invocation); //onbefore methodun başında çalışmaya sebep olur.
            try
            {
                invocation.Proceed();
            }
            catch (Exception e)
            {
                isSuccess = false;
                OnException(invocation, e); //hata aldığında çalışır
                throw;
            }
            finally
            {
                if (isSuccess)
                {
                    OnSuccess(invocation); //başarılı olduğunda
                }
            }
            OnAfter(invocation);//method sonunda çalışır
        }
    }
}
