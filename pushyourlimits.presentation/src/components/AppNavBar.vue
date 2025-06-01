<template>
  <v-card flat color="white">
    <!-- Navigatiebar -->
    <v-toolbar flat color="white" class="px-6">
      <!-- Links uitgelijnde navigatie -->
      <v-toolbar-items class="me-auto">
        <RouterLink
          v-for="item in items"
          :key="item.title"
          :to="item.route"
          class="nav-link"
          exact-active-class="nav-link-active"
        >
          {{ item.title }}
        </RouterLink>
      </v-toolbar-items>

      <div class="d-flex align-center">
        <v-btn to="/login" variant="outlined" class="login-btn me-3">
          Login
        </v-btn>
        <v-btn to="/register" variant="flat" class="register-btn">
          Inschrijven
        </v-btn>
      </div>
    </v-toolbar>
  </v-card>
</template>

<script setup>
const items = [
  { title: "Home", route: "/" },
  // { title: "Abonnementen", route: "/subscriptions" },
  { title: "Goal", route: "/goal" },
  { title: "Streak", route: "/streak" },
];
</script>

<style scoped>
.nav-link {
  color: #356859;
  text-decoration: none;
  margin-right: 20px;
  font-weight: 500;
  font-size: 16px;
  transition: color 0.3s, border-bottom 0.3s;
}

.nav-link:hover {
  color: #6fb98f;
}

.nav-link-active {
  border-bottom: 2px solid #6fb98f;
  color: #6fb98f;
  padding-bottom: 2px;
}
</style>
