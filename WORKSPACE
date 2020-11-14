load("@bazel_tools//tools/build_defs/repo:http.bzl", "http_archive")

# <-- JSON | JSONNET -->
http_archive(
    name = "io_bazel_rules_jsonnet",
    sha256 = "68b5bcb0779599065da1056fc8df60d970cffe8e6832caf13819bb4d6e832459",
    strip_prefix = "rules_jsonnet-0.2.0",
    urls = ["https://github.com/bazelbuild/rules_jsonnet/archive/0.2.0.tar.gz"],
)

load("@io_bazel_rules_jsonnet//jsonnet:jsonnet.bzl", "jsonnet_repositories")

jsonnet_repositories()

load("@jsonnet_go//bazel:repositories.bzl", "jsonnet_go_repositories")

jsonnet_go_repositories()

load("@jsonnet_go//bazel:deps.bzl", "jsonnet_go_dependencies")

jsonnet_go_dependencies()

# <-- CPP | BOOST -->

new_local_repository(
    name = "boost",
    build_file = "third_party/cpp/boost/boost.BUILD",
    path = "third_party/cpp/boost",
)

new_local_repository(
    name = "data_frame",
    build_file = "third_party/cpp/DataFrame/data_frame.BUILD",
    path = "third_party/cpp/DataFrame",
)
