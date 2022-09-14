/* eslint-disable @next/next/no-img-element */
import type { NextPage } from "next";
import Head from "next/head";
import Image from "next/image";
import Header from "../components/Header";
import styles from "../styles/Home.module.css";

const Home: NextPage = () => {
  return (
    <div className="max-w-7xl mx-auto">
      <Head>
        <title>Medium blog</title>
        {/* <link rel="icon" href="/public/favicon.ico" /> */}
      </Head>
      <Header />

      {/* Hero section */}
      <div className="flex justify-between items-center bg-yellow-400 border-y border-black py-10 ">
        <div className="px-10 space-y-5">
          <h1 className="text-6xl max-w-xl font-serif">
            <span className="underline decoration-black decoration-4">
              Medium
            </span>{" "}
            is a place to write, read, and connect
          </h1>
          <h2>
            It&apos;s easy and free to post your thinking on any topic and
            connect with millions of readers.
          </h2>
        </div>

        <img
          className="hidden md:inline-flex h-32 lg:h-52 px-10"
          src="https://upload.wikimedia.org/wikipedia/commons/thumb/a/a5/Medium_icon.svg/1200px-Medium_icon.svg.png"
          alt="logo"
        />
      </div>

      {/* Posts */}
    </div>
  );
};

export default Home;
