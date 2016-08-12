using EPiServer.Data.Dynamic;

namespace FiftyOneDegrees.Models
{
    [EPiServerDataStore(AutomaticallyCreateStore = true)]
    public class HasTouchScreen : BooleanModel
    {
    }
}