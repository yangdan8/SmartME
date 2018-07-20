// Type definitions for iview 2.5.1
// Project: https://github.com/iview/iview
// Definitions by: yangdan
// Definitions: https://github.com/yangdan8/iview.git
import Vue from "vue";

export default Switch;

export interface Switch extends Vue {
  /**
   * 指定当前是否选中，可以使用 v-model 双向绑定数据
   * @default false
   */
  value: boolean;
  /**
   * 开关的尺寸，可选值为large、small、default或者不写。建议开关如果使用了2个汉字的文字，使用 large。
   */
  size: string;
  /**
   * 禁用开关
   * @default false
   */
  disabled: boolean;
  /**
   * 选中时的值，当使用类似 1 和 0 来判断是否选中时会很有用
   * @default true
   */
  'true-value': string | number | boolean;
  /**
   * 没有选中时的值，当使用类似 1 和 0 来判断是否选中时会很有用
   * @default false
   */
  'false-value': string | number | boolean;
  /**
   * 开关变化时触发，返回当前的状态
   */
  $emit(eventName: 'on-change', value: boolean): this;
  /**
   * slot插槽对象
   */
  $slot: {
    /**
     * 自定义显示打开时的内容
     */
    open: Vue,
    /**
     * 自定义显示关闭时的内容
     */
    close: Vue
  };
}