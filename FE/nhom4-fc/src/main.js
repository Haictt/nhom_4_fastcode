import './style/base/index.css'
import './style/layout/index.css'

import { createApp } from 'vue'

import App from './App.vue'
import MButton from './components/button/MButton.vue'
import MCheckbox from './components/checkbox/MCheckbox.vue'
import MCombobox from './components/combobox/MCombobox.vue'
import MFormControl from './components/form/MFormControl.vue'
import MPopup from './components/popup/MPopup.vue'
import MSelect from './components/select/MSelect.vue'
import MTable from './components/table/MTable.vue'
import MTh from './components/table/MTh.vue'
import MTPaging from './components/table/MTPaging.vue'
import MTToolbar from './components/table/MTToolbar.vue'
import MTextarea from './components/textarea/MTextarea.vue'
import MTextField from './components/textfield/MTextField.vue'

const app = createApp(App)

app.component('MButton', MButton)
app.component('MCheckbox', MCheckbox)
app.component('MTextField', MTextField)
app.component('MTextarea', MTextarea)
app.component('MSelect', MSelect)
app.component('MCombobox', MCombobox)
app.component('MTable', MTable)
app.component('MTToolbar', MTToolbar)
app.component('MTPaging', MTPaging)
app.component('MTh', MTh)
app.component('MFormControl', MFormControl)
app.component('MPopup', MPopup)

app.mount('#app')
