/**
 * router/index.ts
 *
 * Automatic routes for `./src/pages/*.vue`
 */

// Composables
import { createRouter, createWebHistory } from "vue-router/auto";
// import { routes } from "vue-router/auto-routes";
import HomeView from "@/views/HomeView.vue";
import SubscriptionsView from "@/views/SubscriptionsView.vue";
import LoginView from "@/views/LoginView.vue";
import GoalSetUp from "@/components/GoalSetUp.vue";
import Streak from "@/components/ProgressStreak.vue";

const routes = [
  {
    path: "/",
    name: "home",
    component: HomeView,
  },
  {
    path: "/subscriptions",
    name: "subscriptions",
    component: SubscriptionsView,
  },
  {
    path: "/login",
    name: "login",
    component: LoginView,
  },
  {
    path: "/goalsetup",
    name: "goalsetup",
    component: GoalSetUp,
  },
  {
    path: "/streak",
    name: "streak",
    component: Streak,
  },
];

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes,
});

// Workaround for https://github.com/vitejs/vite/issues/11804
router.onError((err, to) => {
  if (err?.message?.includes?.("Failed to fetch dynamically imported module")) {
    if (!localStorage.getItem("vuetify:dynamic-reload")) {
      console.log("Reloading page to fix dynamic import error");
      localStorage.setItem("vuetify:dynamic-reload", "true");
      location.assign(to.fullPath);
    } else {
      console.error("Dynamic import error, reloading page did not fix it", err);
    }
  } else {
    console.error(err);
  }
});

router.isReady().then(() => {
  localStorage.removeItem("vuetify:dynamic-reload");
});

export default router;
