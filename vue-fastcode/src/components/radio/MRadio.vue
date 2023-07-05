<template>
  <label class="m-checkbox" :tabIndex="tabIndex || -1" @keydown.space="$emit('update:modelValue', !modelValue)"
    @keydown.prevent>
    <input type="checkbox" :checked="modelValue" @input="$emit('update:modelValue', $event.target.checked)" />
    <span class="checked">
      <slot name="active-icon">
        <span :class="temp ? 'checkmark-temp' : 'checkmark'"></span>
      </slot>
    </span>
    <span class="unchecked">
      <slot name="default-icon">
        <span class="checkmark"></span>
      </slot>
    </span>
    <span class="checkbox-text">
      <slot></slot>
    </span>
  </label>
</template>

<script>
export default {
  name: 'MCheckbox',
  props: {
    modelValue: [String, Number], // Giá trị của radio
    temp: Boolean,
    value: [String, Number], // Giá trị của radio
    tabIndex: {
      type: Number,
      required: false   // Mặc định: -1
    }
    /**
     * Ngoài ra còn 3 vị trí slot:
     * v-slot:active-icon     Để thay thế checked-icon với icon tùy chỉnh
     * v-slot: default-icon   Để thay thế unchecked-icon với icon tùy chỉnh
     * v-slot                 Để hiển thị thêm nội dung text trong checkbox
     */
  },
  emits: ['update:modelValue']
}
</script>