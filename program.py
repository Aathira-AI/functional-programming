from typing import Callable, List


class Utils:  

    @staticmethod
    def is_string_starts_with_s(item: str) -> bool:
        return item.startswith("S")

    @staticmethod
    def is_string_starts_with_j(item: str) -> bool:
        return item.startswith("J")

    @staticmethod
    def get_names(names: List[str], predicate: Callable[[str], bool]) -> List[str]:
        results: List[str] = []
        for name in names:
            if predicate(name):
                results.append(name)
        return results


def main() -> None:
    names = ["Sam", "John", "Steve", "Alice", "Sarah", "Bob"]

    results = Utils.get_names(names, Utils.is_string_starts_with_s)
    for name in results:
        print(name)

    results = Utils.get_names(names, Utils.is_string_starts_with_j)
    for name in results:
        print(name)


if __name__ == "__main__":
    main()
