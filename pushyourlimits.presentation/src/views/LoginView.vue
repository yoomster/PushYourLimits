<template>
  <v-app>
    <v-container class="d-flex justify-center mt-10">
      <v-card width="500" class="pa-6" elevation="3" color="white">
        <v-card-title class="justify-center">
          <h1 class="text-h4 font-weight-bold" style="color: #356859">Login</h1>
        </v-card-title>
        <v-card-text>
          <v-form ref="form">
            <v-text-field
              v-model="email"
              label="Email"
              prepend-icon="mdi-account-circle"
              type="email"
              :rules="[rules.required, rules.email]"
              class="mb-4"
            />
            <v-text-field
              v-model="password"
              :type="showPassword ? 'text' : 'password'"
              label="Wachtwoord"
              prepend-icon="mdi-lock"
              :append-icon="showPassword ? 'mdi-eye' : 'mdi-eye-off'"
              @click:append="showPassword = !showPassword"
              :rules="[rules.required]"
            />
          </v-form>
        </v-card-text>

        <!-- Acties -->
        <v-card-actions class="d-flex justify-space-between">
          <RouterLink to="/register">
            <v-btn variant="outlined" class="register-btn">Registreer</v-btn>
          </RouterLink>
          <v-btn class="login-btn" @click="login">Login</v-btn>
        </v-card-actions>
      </v-card>
    </v-container>
  </v-app>
</template>

<script setup>
import { ref } from "vue";
import { useRouter } from "vue-router";
import axios from "axios";

const email = ref("");
const password = ref("");
const showPassword = ref(false);
const form = ref();
const error = ref("");

const router = useRouter();

const rules = {
  required: (v) => !!v || "Verplicht veld",
  email: (v) => /.+@.+\..+/.test(v) || "Vul een geldig e-mailadres in",
};

const login = async () => {
  if (form.value?.validate()) {
    try {
      const response = await axios.post("/IAM/login", {
        email: email.value,
        password: password.value,
      });
      localStorage.setItem("token", response.data.token);
      router.push("/home");
    } catch (err) {
      error.value = "Login failed";
    }
  }
};
</script>
