namespace DarkSoulsII.DebugView.Model.Savegame
{
    /// <summary>
    ///     Saves instantly if reason is less than 5.
    ///     Else saves 30s after loading the game/the last save and resets the reason to Default
    /// </summary>
    public enum SaveReason
    {
        Unknown0 = 0,
        Quit,
        Death,
        Teleport,
        EnterFogGate,
        Unknown5,
        Unknown6,
        PickUpItem,
        RetrieveSouls,
        Unknown9,
        MapChange,
        Unknown11,
        Unknown12,
        Unknown13,
        Default
    }
}
