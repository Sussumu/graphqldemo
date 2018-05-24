<template>
  <div class="container">
    <form>
      <div class="form-group">
        <label for="queryInput">GraphQL query:</label>
        <textarea id="queryInput" class="form-control" rows="10" v-model="query"></textarea>
      </div>
      <button type="submit" class="btn btn-primary" v-on:click.prevent="search">Send query!</button>
    </form>
    <div class="container">
      {{queryResponse}}
    </div>
  </div>
</template>

<script>
import Axios from 'axios'

export default {
  name: 'GraphqlQueryTextBox',
  components: {
    Axios
  },
  data: function () {
    return {
      query: "",
      queryResponse: ""
    }
  },
  methods: {
    search: function () {
      Axios.get("http://localhost:63358/api", {params: this.query})
        .then(function (response) {
          this.queryResponse = response.data;
        })
        .catch(function (error) {
          this.queryResponse = error;
        })
    },
    initializeInput: function () {
      this.query = `query {
  user {
    name
  }
}`
    }
  },
  mounted: function () {
    this.initializeInput();
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
</style>
