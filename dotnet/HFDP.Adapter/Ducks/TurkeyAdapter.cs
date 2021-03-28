﻿using HFDP.Adapter.Turkeys;

namespace HFDP.Adapter.Ducks
{
    public class TurkeyAdapter : IDuck
    {
        private readonly ITurkey _turkey;

        public TurkeyAdapter(ITurkey turkey)
        {
            _turkey = turkey;
        }

        public void Quack()
        {
            _turkey.Gobble();
        }

        public void Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                _turkey.Fly();
            }
        }
    }
}
