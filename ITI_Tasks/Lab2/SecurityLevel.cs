namespace ITI_Tasks.Lab2;

[Flags]public enum SecurityLevel {
    NONE = -1,
    GUEST = 0,
    DEVELOPER = 3,
    SECERTARY =6,
    DBA = 9
}