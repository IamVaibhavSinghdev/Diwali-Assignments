const express = require("express");
const bodyParser = require("body-parser");
const mysql = require("mysql2");

const app = express();
const port = 3000;


app.use(bodyParser.json());


const db = mysql.createConnection({
  host: "localhost",
  user: "uroot",         
  password: "uroot",  
  database: "userdb1"
});


db.connect((err) => {
  if (err) {
    console.error("❌ Database connection failed:", err);
  } else {
    console.log("✅ Connected to MySQL database!");
  }
});


app.post("/register", (req, res) => {
  const { first_name, last_name, email, user_id, password } = req.body;


  if (!first_name || !last_name || !email || !user_id || !password) {
    return res.status(400).json({ error: "All fields are required" });
  }


  const sql = "INSERT INTO Users (first_name, last_name, email, user_id, password) VALUES (?, ?, ?, ?, ?)";

  db.query(sql, [first_name, last_name, email, user_id, password], (err, result) => {
    if (err) {
      console.error("❌ Error inserting user:", err);
      return res.status(500).json({ error: "Database error" });
    }

    res.status(201).json({ message: "User registered successfully!", userId: result.insertId });
  });
});


app.listen(port, () => {
  console.log(`🚀 Server running on http://localhost:${3000}`);
});
