namespace CustomShips.ZProperties {
    public class ZBool : ZProperty<bool> {
        public ZBool(string key, bool defaultValue, ZNetView zNetView) : base(key, defaultValue, zNetView) {
        }

        public override bool Get() {
            return NetView.GetZDO().GetBool(KeyHash, DefaultValue);
        }

        protected override void SetValue(bool value) {
            NetView.GetZDO().Set(KeyHash, value);
        }
    }
}
