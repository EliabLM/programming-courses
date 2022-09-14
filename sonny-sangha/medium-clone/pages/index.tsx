import type { NextPage } from "next";
import Head from "next/head";
import Image from "next/image";
import Header from "../components/Header";
import styles from "../styles/Home.module.css";

const Home: NextPage = () => {
  return (
    <div>
      <Head>
        <title>Medium blog</title>
        {/* <link rel="icon" href="/public/favicon.ico" /> */}
      </Head>
      <Header />
    </div>
  );
};

export default Home;
