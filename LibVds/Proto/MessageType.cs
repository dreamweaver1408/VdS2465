namespace LibVds.Proto
{
    public enum MessageType
    {
        Meldung_Ein = 0x00,
        Meldung_Aus = 0x80,
        Brandmeldung_Ausgeloest = 0x10,
        Brandmeldung_Zurueckgesetzt = 0x90,

    }
}