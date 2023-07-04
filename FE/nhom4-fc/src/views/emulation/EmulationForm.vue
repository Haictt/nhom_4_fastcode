<template>
  <MPopup :open="true" title="Thêm danh hiệu thi đua" @close="$emit('close')">
    <template v-slot:btns>
      <div class="m-icon help"></div>
      <div class="m-icon close" @click="$emit('close')"></div>
    </template>
    <MFormControl label="Tên danh hiệu thi đua" :required="true" :error="error.EmulationTitleName">
      <MTextField v-model="form.EmulationTitleName" placeholder="Nhập tên danh hiệu thi đua"
        :error="error.EmulationTitleName" @blur="validate" />
    </MFormControl>
    <div class="main-left">
      <MFormControl label="Mã danh hiệu" :required="true" :error="error.EmulationTitleCode">
        <MTextField v-model="form.EmulationTitleCode" placeholder="Nhập mã danh hiệu" :error="error.EmulationTitleCode"
          @blur="validate" />
      </MFormControl>
    </div>
    <div class="main-right">
      <MFormControl label="Đối tượng khen thưởng" :required="true" :error="error.ApplyObject">
        <div class="flex--row">
          <span class="flex-1">
            <MCheckbox v-model="form.ApplyObject.individual"> Cá nhân </MCheckbox>
          </span>
          <span class="flex-1">
            <MCheckbox v-model="form.ApplyObject.collective">Tập thể</MCheckbox>
          </span>
        </div>
      </MFormControl>
    </div>
    <div class="main-left">
      <MFormControl label="Cấp khen thưởng" :required="true" :error="error.CommendationLevel">
        <MCombobox v-model="form.CommendationLevel" :list="commendationLevelList" placeholder="Chọn hiện vật khen thưởng"
          :error="Boolean(error.CommendationLevel)" :blur="validate" />
      </MFormControl>
    </div>
    <div class="main-right">
      <MFormControl label="Loại phong trào áp dụng" :required="true" :error="error.MovementType">
        <div class="flex--row">
          <span class="flex-1">
            <MCheckbox v-model="form.MovementType.usually">Thường xuyên</MCheckbox>
          </span>
          <span class="flex-1">
            <MCheckbox v-model="form.MovementType.batched">Theo đợt</MCheckbox>
          </span>
        </div>
      </MFormControl>
    </div>
    <MFormControl label="Ghi chú">
      <MTextarea placeholder="Nhập ghi chú" />
    </MFormControl>
    <template v-slot:actions>
      <MButton variant="secondary" text="Hủy" color="secondary" @click="$emit('close')"></MButton>
      <MButton variant="outline" text="Lưu & thêm mới" @click="saveAndNew"></MButton>
      <MButton variant="primary" text="Lưu" @click="save"></MButton>
    </template>
  </MPopup>
</template>

<script>
import convertor from '../../js/convertor'
export default {
  name: 'EmulationForm',
  props: ['emulation'], // Đối tượng mặc định để sửa
  emits: ['close'],
  data() {
    return {
      form: {
        EmulationTitleID: '',
        EmulationTitleName: '',
        EmulationTitleCode: 'D13',
        ApplyObject: {
          individual: true,
          collective: false
        },
        CommendationLevel: 0,
        MovementType: {
          usually: true,
          batched: false
        },
        Inactive: ''
      },
      error: {
        EmulationTitleName: '',
        EmulationTitleCode: '',
        ApplyObject: '',
        CommendationLevel: '',
        MovementType: '',
        Inactive: ''
      }
    }
  },
  computed: {
    commendationLevelList() {
      const list = []
      Object.keys(convertor.commendationLevel).forEach((key) => {
        list.push({
          value: Number(key),
          label: convertor.commendationLevel[key]
        })
      })
      return list
    }
  },
  methods: {
    'form.CommendationLevel': function (value) {
      console.log(value)
    },
    validate() {
      if (!this.form.EmulationTitleName)
        this.error.EmulationTitleName = 'Tên danh hiệu thi đua không được để trống.'
      else this.error.EmulationTitleName = ''
      if (!this.form.EmulationTitleCode)
        this.error.EmulationTitleCode = 'Mã danh hiệu không được để trống.'
      else this.error.EmulationTitleCode = ''
      if (this.form.CommendationLevel < 0 || this.form.CommendationLevel > 4)
        this.error.CommendationLevel = 'Cấp khen thưởng không được để trống.'
      else this.error.CommendationLevel = ''
      if (!this.form.ApplyObject.individual && !this.form.ApplyObject.collective)
        this.error.ApplyObject = 'Đối tượng khen thưởng không được để trống.'
      else this.error.ApplyObject = ''
      if (!this.form.MovementType.usually && !this.form.MovementType.batched)
        this.error.MovementType = 'Loại phong trào không được để trống.'
      else this.error.MovementType = ''
    },
    saveAndNew() {
      this.save()
      this.form = {
        EmulationTitleID: '',
        EmulationTitleName: '',
        EmulationTitleCode: '',
        ApplyObject: {
          individual: false,
          collective: false
        },
        CommendationLevel: '',
        MovementType: {
          usually: false,
          batched: false
        },
        Inactive: ''
      }
    },
    save() {
      console.log(this.form)
    }
  },
  watch: {
    form: {
      deep: true,
      handler: function () {
        this.validate()
      }
    }
  }
}
</script>

<style scoped>
.main-left {
  display: inline-block;
  width: calc(50% - 5px);
  vertical-align: top;
  margin-right: 10px;
}

.main-right {
  display: inline-block;
  width: calc(50% - 5px);
  vertical-align: top;
}
</style>
