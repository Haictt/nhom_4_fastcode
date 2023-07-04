<template>
  <div class="filter-box">
    <div class="box-bg" @click="$emit('close')"></div>
    <div class="custom-arrow"></div>
    <div class="box-container">
      <div class="box-header">
        <span class="box-title">Lọc danh hiệu</span>
        <span class="m-icon close" @click="$emit('close')"></span>
      </div>
      <div class="box-content">
        <MFormControl label="Đối tượng khen thưởng">
          <MCombobox v-model="filter.applyObject" :list="applyObjectList" />
        </MFormControl>
        <MFormControl label="Cấp khen thưởng">
          <MCombobox v-model="filter.commendationLevel" :list="commendationLevelList">
          </MCombobox>
        </MFormControl>
        <MFormControl label="Loại phong trào">
          <MCombobox v-model="filter.movementType" :list="movementTypeList" />
        </MFormControl>
        <MFormControl label="Trạng thái">
          <MCombobox v-model="filter.inactive" :list="inactiveList" />
        </MFormControl>
      </div>
      <div class="box-footer">
        <MButton variant="secondary" text="Hủy" color="secondary" @click="$emit('close')"></MButton>
        <MButton variant="primary" text="Áp dụng" @click="submit"></MButton>
      </div>
    </div>
  </div>
</template>

<script>
import convertor from '../../js/convertor'

export default {
  name: 'FilterBox',
  emits: ['close', 'apply'],
  data() {
    return {
      filter: {
        applyObject: null,
        commendationLevel: null,
        movementType: null,
        inactive: null
      }
    }
  },
  computed: {
    applyObjectList() {
      const list = [{ label: 'Tất cả', value: null }]
      Object.keys(convertor.applyObject).forEach((key) => {
        list.push({
          value: Number(key),
          label: convertor.applyObject[key]
        })
      })
      return list
    },
    commendationLevelList() {
      const list = [{ label: 'Tất cả', value: null }]
      Object.keys(convertor.commendationLevel).forEach((key) => {
        list.push({
          value: Number(key),
          label: convertor.commendationLevel[key]
        })
      })
      return list
    },
    movementTypeList() {
      const list = [{ label: 'Tất cả', value: null }]
      Object.keys(convertor.movementType).forEach((key) => {
        list.push({
          value: Number(key),
          label: convertor.movementType[key]
        })
      })
      return list
    },
    inactiveList() {
      const list = [{ label: 'Tất cả', value: null }]
      Object.keys(convertor.inactive).forEach((key) => {
        list.push({
          value: Number(key),
          label: convertor.inactive[key]
        })
      })
      return list
    }
  },
  methods: {
    submit() {
      this.$emit('apply', this.filter)
      this.$emit('close')
    }
  }
}
</script>

<style scoped>
.filter-box {
  margin-top: 12px;
  position: absolute;
  top: 100%;
  right: 13px;
  display: block;
  z-index: 15;
  border-radius: 4px;
  box-shadow: 0 0 16px rgba(23, 27, 42, 0.24);
  background-color: white;
}

.filter-box .custom-arrow {
  position: absolute;
  top: 0;
  right: 57px;
  border-left: 8px solid transparent;
  border-right: 8px solid transparent;
  border-bottom: 8px solid white;
  transform: translateY(-100%);
  transition: border-color 0.2s linear;
  box-shadow: 0 -20px 20px 0 rgba(0, 0, 0, 0.08);
}

.box-bg {
  position: fixed;
  top: 0;
  left: 0;
  width: 100vw;
  height: 100vh;
  z-index: 10;
}

.box-container {
  position: relative;
  width: 360px;
  z-index: 11;
}

.box-header {
  box-sizing: border-box;
  width: 100%;
  padding: 12px 22px 8px 24px;
  background-color: white;
  display: flex;
  align-items: center;
  justify-content: space-between;
  border-top-right-radius: 4px;
  border-top-left-radius: 4px;
}

.box-header .m-icon {
  cursor: pointer;
}

.box-header .box-title {
  font-size: 18px;
  font-weight: 700;
}

.box-content {
  box-sizing: border-box;
  width: 100%;
  padding: 12px 24px 10px;
  background-color: white;
}

.box-content .m-form-label {
  color: #666;
  font-size: 14px;
  font-weight: 500;
}

.box-footer {
  box-sizing: border-box;
  width: 100%;
  padding: 12px 24px;
  background-color: #fbfbfe;
  border-bottom-right-radius: 4px;
  border-bottom-left-radius: 4px;
  border-top: 1px solid #ddd;
  display: flex;
  flex-flow: row nowrap;
  justify-content: end;
  column-gap: 10px;
}
</style>
