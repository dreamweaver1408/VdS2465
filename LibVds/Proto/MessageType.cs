namespace LibVds.Proto
{
    public enum MessageType
    {
        Meldung_Ein = 0x00,
        Meldung_Aus = 0x80,
        Brandmeldung_Ausgeloest = 0x10,
        Brandmeldung_Zurueckgesetzt = 0x90,
        Brand_manueller_Melder_Ausgeloest = 0x11,
        Brand_manueller_Melder_Zurueckgesetzt = 0x91,
        Brand_automatischer_Melder_Ausgeloest = 0x12,
        Brand_automatischer_Melder_Zurueckgesetzt = 0x92,
        Brandmeldung_aus_Loeschanlage_Ausgeloest = 0x13,
        Brandmeldung_aus_Loeschanlage_Zurueckgesetzt = 0x93,

        Ueberfall_Einbruchmeldung_Ausgeloest = 0x20,
        Ueberfall_Einbruchmeldung_Zurueckgesetzt = 0xA0,
        Ueberfall_Ausgesloest = 0x21,
        Ueberfall_Zurueckgesetzt = 0xA1,
        Einbruch_Ausgeloest = 0x22,
        Einbruch_Zurueckgesetzt = 0xA2,
        Sabotage_Ausgeloest = 0x23,
        Sabotage_Zurueckgesetzt = 0xA3,
        Geiselnahme_Ausgeloest = 0x24,
        Geiselnahme_Zurueckgesetzt = 0xA4,
        Bereichsmeldung_Ueberfall_Einbruch_Ausgeloest = 0x2F,
        Bereichsmeldung_Ueberfall_Einbruch_Zurueckgesetzt = 0x24


    }
}