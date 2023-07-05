<template>
  <div class="m-table-toolbar">
    <div class="toolbar-left">
      <slot v-if="float == 'right' || !actions" name="left"></slot>
      <slot v-if="actions && float == 'left'" name="actions"></slot>
    </div>
    <div class="toolbar-right">
      <slot v-if="float == 'left' || !actions" name="right"></slot>
      <slot v-if="actions && float == 'right'" name="actions"></slot>
    </div>
  </div>
</template>

<script>
export default {
  name: 'MTToolbar',
  props: {
    actions: Boolean, // Trạng thái có hiển thị action không
    float: String // Vị trí hiển thị action: ['left', 'right']
  }
}
</script>