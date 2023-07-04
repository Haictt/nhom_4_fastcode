<template>
  <MTToolbar float="right" :actions="countChecked > 0">
    <template v-slot:left>
      <MTextField placeholder="Nhập mã hoặc tên danh hiệu..." right-icon="m-icon search" />
      <span :style="{ position: 'relative' }">
        <MButton variant="secondary" left-icon="m-icon filter" text="Bộ lọc" color="secondary" @click="filterOpen = true">
        </MButton>
        <FilterBox v-if="filterOpen" @close="filterOpen = false"></FilterBox>
      </span>
    </template>
    <template v-slot:right>
      <MButton left-icon="m-icon add-white" text="Thêm danh hiệu" color="primary" @click="formOpen = true"></MButton>
    </template>
    <template v-slot:actions>
      <span>
        Đã chọn
        <b>{{ countChecked >= 10 ? countChecked : '0' + countChecked }}</b>
      </span>
      <MButton variant="link" text="Bỏ chọn" color="primary"
        @click="emulationsList.forEach((item) => (item['IsChecked'] = false))"></MButton>
      <MButton variant="outline" text="Sử dụng" color="primary"></MButton>
      <MButton variant="secondary" text="Ngừng sử dụng" color="secondary"></MButton>
      <MButton variant="outline" text="Xóa" color="error"></MButton>
    </template>
  </MTToolbar>
  <div :style="{ 'max-height': 'calc(100% - 36px - 16px)' }" class="flex-1">
    <MTable>
      <template v-slot:thead>
        <MTh text-align="center" width="53px">
          <MCheckbox :modelValue="countChecked > 0" @update:modelValue="countChecked = $event"
            :temp="countChecked !== displayList.length"></MCheckbox>
        </MTh>
        <MTh text-align="left" width="310px" resizable>Tên danh hiệu thi đua</MTh>
        <MTh text-align="left" width="160px">Mã danh hiệu</MTh>
        <MTh text-align="left" width="180px">Đối tượng khen thưởng</MTh>
        <MTh text-align="left" width="200px">Cấp khen thưởng</MTh>
        <MTh text-align="left" width="200px">Loại phong trào</MTh>
        <MTh text-align="left" width="180px">Trạng thái</MTh>
      </template>
      <template v-slot:tbody>
        <tr v-for="(item, index) in formatData" :key="index">
          <td class="text-align--center">
            <MCheckbox v-model="displayList[index]['IsChecked']"></MCheckbox>
          </td>
          <td class="text-align--left">{{ item['EmulationTitleName'] }}</td>
          <td class="text-align--left">{{ item['EmulationTitleCode'] }}</td>
          <td class="text-align--left">{{ item['ApplyObject'] }}</td>
          <td class="text-align--left">{{ item['CommendationLevel'] }}</td>
          <td class="text-align--left">{{ item['MovementType'] }}</td>
          <td class="text-align--left">{{ item['Inactive'] }}</td>
        </tr>
      </template>
      <template v-slot:paging>
        <MTPaging :total="emulationsList.length" v-model:pageSize="pageSize" v-model:page="page"
          :sizeList="[10, 20, 50, 100]" />
      </template>
    </MTable>
  </div>
  <EmulationForm v-if="formOpen" @close="formOpen = false"></EmulationForm>
</template>

<script>
import convertor from '../../js/convertor.js'
import EmulationForm from '../../views/emulation/EmulationForm.vue'
import FilterBox from '../../views/emulation/FilterBox.vue'
export default {
  name: 'EmulationList',
  components: { EmulationForm, FilterBox },
  data() {
    return {
      emulationsList: [],
      displayList: [],
      formOpen: false,
      filterOpen: false,
      page: 1,
      pageSize: 50
    }
  },
  computed: {
    /**
     * Quản lý số checkbox
     * Author: PCTHANH (27/06/2023)
     */
    countChecked: {
      /**
       * Lấy số lượng checkebox đã checked
       * @returns Number Số lượng checkbox đâ checked
       */
      get() {
        return this.emulationsList.filter((item) => item['IsChecked']).length
      },
      /**
       * Đặt lại toàn bộ checkbox
       * @param {boolean} value Trạng thái checked muốn đặt
       */
      set(value) {
        if (value) {
          this.displayList.forEach((item) => (item['IsChecked'] = true))
        } else {
          this.displayList.forEach((item) => (item['IsChecked'] = false))
        }
      }
    },
    /**
     * Format dữ liệu để hiển thị
     * Author: PCTHANH (04/07/2023)
     * @returns Danh sách đối tượng đúng mẫu để hiển thị
     */
    formatData() {
      return this.displayList.map((item) => ({
        ...item,
        ApplyObject: convertor.applyObject[item['ApplyObject']],
        CommendationLevel: convertor.commendationLevel[item['CommendationLevel']],
        MovementType: convertor.movementType[item['MovementType']],
        Inactive: convertor.inactive[item['Inactive']]
      }))
    }
  },
  mounted() {
    // Load dữ liệu
    fetch('/data.json')
      .then((res) => res.json())
      .then((data) => {
        console.log(data)
        // Hiển thị
        this.emulationsList = data['PageData']
        this.display()
      })
      .catch((e) => console.log(e))
  },
  methods: {
    display() {
      const start = (this.page - 1) * this.pageSize
      const end = Math.min(this.page * this.pageSize, this.emulationsList.length)
      this.displayList = this.emulationsList.slice(start, end)
    }
  },
  watch: {
    page() {
      this.display()
    },
    pageSize() {
      this.display()
    }
  }
}
</script>

<style scoped>
.m-table {
  box-shadow: 0 0 11px rgba(0, 0, 0, 0.08);
}

.m-table-toolbar .textfield {
  width: 265px;
}

th:first-child,
td:first-child {
  position: sticky;
  left: 0;
  background-color: white;
  z-index: 1;
}

tr:hover td:first-child {
  background-color: unset;
}
</style>
