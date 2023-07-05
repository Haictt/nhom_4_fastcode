import './style/base/index.css';
import './style/layout/index.css';

import router from '@/router/router.js';
import axios from 'axios';
import emitter from 'tiny-emitter/instance';
import { createApp } from 'vue';

import App from './App.vue';
import MButton from './components/button/MButton.vue';
import MCheckbox from './components/checkbox/MCheckbox.vue';
import MCombobox from './components/combobox/MCombobox.vue';
import MFormControl from './components/form/MFormControl.vue';
import MPopup from './components/popup/MPopup.vue';
import MSelect from './components/select/MSelect.vue';
import MTable from './components/table/MTable.vue';
import MTh from './components/table/MTh.vue';
import MTPaging from './components/table/MTPaging.vue';
import MTToolbar from './components/table/MTToolbar.vue';
import MTextarea from './components/textarea/MTextarea.vue';
import MTextField from './components/textfield/MTextField.vue';
import MISAEnum from './helpers/enum';
import MISAResource from './helpers/resource';

const app = createApp(App);

app.config.globalProperties.$_emitter = emitter;
app.config.globalProperties.$_MISAResource = MISAResource;
app.config.globalProperties.$_MISAEnum = MISAEnum;
app.config.globalProperties.$_LANG_CODE = "VN";
app.config.globalProperties.$_axios = axios;

app.use(router);

app.component("MButton", MButton);
app.component("MCheckbox", MCheckbox);
app.component("MTextField", MTextField);
app.component("MTextarea", MTextarea);
app.component("MSelect", MSelect);
app.component("MCombobox", MCombobox);
app.component("MTable", MTable);
app.component("MTToolbar", MTToolbar);
app.component("MTPaging", MTPaging);
app.component("MTh", MTh);
app.component("MFormControl", MFormControl);
app.component("MPopup", MPopup);

app.mount("#app");
