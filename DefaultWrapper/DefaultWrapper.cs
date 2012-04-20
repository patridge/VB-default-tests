public static class DefaultWrapper {
    public static T GetDefault<T>() {
        return default(T);
    }
}