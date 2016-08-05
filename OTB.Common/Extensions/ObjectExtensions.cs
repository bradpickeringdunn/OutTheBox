namespace System
{
    public static class ObjectExtensions
    {
        public static bool IsNull(this object @object)
        {
            var result = false;

            if(@object == null)
            {
                result = true;
            }

            return result;
        }

        public static bool IsNotNull(this object @object)
        {
            var result = false;

            if (@object != null)
            {
                result = true;
            }

            return result;
        }
    }
}
