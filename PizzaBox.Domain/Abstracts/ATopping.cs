using System.Collections.Generic;

namespace PizzaBox.Domain.Abstracts
{
  public abstract class ATopping : AIngrediant
  {
    public APizza pizza{get;set;} 
  }
}