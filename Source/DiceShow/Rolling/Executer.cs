using System;
using System.Collections.Generic;
using System.Linq;
using DiceShow.Models;

namespace DiceShow
{
    public class Executer : IExecuter
    {

        private IRoller _roller;
        public Executer(IRoller roller)
        {
            _roller = roller;
        }

        public Executed Execute(Roll roll)
        {
            var ret = new Executed();

            try
            {
                ret.Result = new Result
                {
                    
                    RolledDice = from d in roll.Dice
                                 select new Tuple<Dice, IEnumerable<int>>(d, from idx in Enumerable.Range(1, d.Number)
                                                                             select _roller.Roll(1, d.Sides))
                };

            }
            catch (Exception ex)
            {
                ret.Exception = ex;
            }


            return ret;
        }
    }
}