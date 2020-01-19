using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate_Event
{
    public delegate void AccountDelegate(string message);
    class Account
    {
        //AccountDelegate _del;
        int _sum;
        public event AccountDelegate Added;
        public event AccountDelegate Adding;
        public event AccountDelegate Withraw;
        //public void MethodToDelegate(AccountDelegate del)
        //{
        //    _del += del;
        //}
        //public void UnmethodToDelegate(AccountDelegate del)
        //{
        //    _del -= del; 
        //}
        public Account(int sum)
        {
            _sum = sum;
        }
        public void Put(int sum)
        {
            if (Adding != null) 
                Adding($"На счёт добавляется: {sum}$");
            _sum += sum;
            if (Added!=null)
            {
                Added($"На счёт добавлено: {sum}$");
            }
            
            
        }
        public void Withdraw(int sum)
        {
            if (_sum>=sum)
            {
                if (Adding != null) Adding($"Будет списано со счета: {sum}$");
                    _sum -= sum;
                if (Added != null)
                {
                    Added($"Списано со счета: {sum}$");
                }
                
            }
            else
            {
                if (Withraw != null)
                {
                    Withraw("На счёту недостаточно средств");
                }
                
            }
        }

    }
}
