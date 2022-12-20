const { prompt } = require("enquirer");

async function main() {
  console.log("Choose your Login Provider");
  console.log(
    " 1.Autho\n 2.Autho.PKCE");
  const response = await prompt({
    type: "input",
    name: "data",
    message: "Please Enter your choice:",
  });
  console.log(`your answer: ${response.data}`);
}
main();
/*
docker image build -t rahuljaiswal1000/nodeconsole:latest .
docker container run --name nodeconsole -it rahuljaiswal1000/nodeconsole
*/