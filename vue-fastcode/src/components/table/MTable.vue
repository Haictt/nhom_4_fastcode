<template>
  <div class="m-table">
    <slot name="toolbar"></slot>
    <div class="table scrollbar">
      <table>
        <thead>
          <tr>
            <slot name="thead"></slot>
          </tr>
        </thead>
        <tbody>
          <slot name="tbody"></slot>
        </tbody>
      </table>
    </div>
    <slot name="paging"></slot>
  </div>
</template>

<script>
export default {
  name: 'MTable'
}
</script>