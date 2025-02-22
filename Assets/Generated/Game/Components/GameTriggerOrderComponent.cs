//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public TriggerOrderComponent triggerOrder { get { return (TriggerOrderComponent)GetComponent(GameComponentsLookup.TriggerOrder); } }
    public bool hasTriggerOrder { get { return HasComponent(GameComponentsLookup.TriggerOrder); } }

    public void AddTriggerOrder(int newValue) {
        var index = GameComponentsLookup.TriggerOrder;
        var component = (TriggerOrderComponent)CreateComponent(index, typeof(TriggerOrderComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceTriggerOrder(int newValue) {
        var index = GameComponentsLookup.TriggerOrder;
        var component = (TriggerOrderComponent)CreateComponent(index, typeof(TriggerOrderComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveTriggerOrder() {
        RemoveComponent(GameComponentsLookup.TriggerOrder);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherTriggerOrder;

    public static Entitas.IMatcher<GameEntity> TriggerOrder {
        get {
            if (_matcherTriggerOrder == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.TriggerOrder);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherTriggerOrder = matcher;
            }

            return _matcherTriggerOrder;
        }
    }
}
